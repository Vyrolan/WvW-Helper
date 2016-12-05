﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using GW2NET.WorldVersusWorld;

namespace Sandbox
{
    class MatchHistory : IEnumerable<KeyValuePair<DateTime, Match>>
    {
        private LinkedList<KeyValuePair<DateTime, Match>> Matches { get; set; }

        public MatchHistory()
        {
            Matches = Deserialize();
        }

        public DateTime LastUpdateTime
        {
            get
            {
                if (Matches.Count == 0)
                    return DateTime.MinValue;
                return Matches.First.Value.Key;
            }
        }

        public Match GetHistoryMatch(int interval)
        {
            var delta = Matches.First;
            for (int i = 0; i < interval; i++)
                if (delta.Next == null)
                    return delta.Value.Value;
                else
                    delta = delta.Next;
            return delta.Value.Value;
        }

        public bool maybeAdd(Match match)
        {
            var now = DateTime.Now;
            if ((now - LastUpdateTime).TotalSeconds >= 60.0 || LastUpdateTime == DateTime.MinValue)
            {
                if (Matches.Count == 61)
                    Matches.RemoveLast();
                Matches.AddFirst(new KeyValuePair<DateTime, Match>(now, match));
                Serialize();

                return true;
            }
            return false;
        }

        public void clear()
        {
            Matches.Clear();
        }

        public static readonly string MATCH_HISTORY_FILE = "C:\\rday\\wvwhistory.dat";
        private static readonly DataContractSerializer _Serializer = new DataContractSerializer(typeof(LinkedList<KeyValuePair<DateTime, Match>>), new Type[] { typeof(RedBorderlands), typeof(GreenBorderlands), typeof(BlueBorderlands), typeof(EternalBattlegrounds), typeof(Bloodlust) });

        public void Serialize()
        {
            using (FileStream fs = File.Create(MATCH_HISTORY_FILE))
            {
                _Serializer.WriteObject(fs, Matches);
            }
        }

        public static LinkedList<KeyValuePair<DateTime, Match>> Deserialize()
        {
            if (File.Exists(MATCH_HISTORY_FILE))
            {
                try
                {
                    using (FileStream fs = File.OpenRead(MATCH_HISTORY_FILE))
                    {
                        return (LinkedList<KeyValuePair<DateTime, Match>>)_Serializer.ReadObject(fs);
                    }
                }
                catch (SerializationException)
                {
                    return new LinkedList<KeyValuePair<DateTime, Match>>();
                }
            }
            else
            {
                return new LinkedList<KeyValuePair<DateTime, Match>>();
            }
        }

        public IEnumerator<KeyValuePair<DateTime, Match>> GetEnumerator()
        {
            return Matches.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
