using System;
using System.Collections.Generic;
using System.Text;

namespace BKI_QLTTQuocAnh.HeThong
{
    class CCollection
    {
        public string[] s;
        int index;

        public CCollection(int ip_length) {
            s = new string[ip_length];
            index = 0;
        }

        public int getIndex() {
            return index;
        }

        public string getString() {
            return s[1];
        }

        public void insert(string ip_str) {
            s[index] = ip_str;
            index++;
        }

        public int countInANotInB(CCollection ip_coll) {
            int v_count = 0;
            for (int i = 0; i < index; i++)
            {
                for (int j = 0; j < ip_coll.index; j++)
                {
                    if (s[i] == ip_coll.s[j])
                    {
                        v_count++;
                        break;
                    }
                }
            }
            return index - v_count;
        }

        public int countNotInAInB(CCollection ip_coll)
        {
            int v_count = 0;
            for (int i = 0; i < index; i++)
            {
                for (int j = 0; j < ip_coll.index; j++)
                {
                    if (s[i] == ip_coll.s[j])
                    {
                        v_count++;
                        break;
                    }
                }
            }
            return ip_coll.index - v_count;
        }

        public CCollection InANotInB(CCollection ip_coll) {
            CCollection v_result = new CCollection(countInANotInB(ip_coll));
            for (int i = 0; i < index; i++)
            {
                int j;
                for (j = 0; j < ip_coll.index; j++)
                {
                    if (s[i] == ip_coll.s[j])
                    {
                        break;
                    }
                }
                if (j == ip_coll.index)
                {
                    v_result.insert(s[i]);
                }
            }
            return v_result;
        }

        public CCollection NotInAInB(CCollection ip_coll)
        {
            CCollection v_result = new CCollection(countNotInAInB(ip_coll));
            for (int i = 0; i < ip_coll.index; i++)
            {
                int j;
                for (j = 0; j < index; j++)
                {
                    if (s[j] == ip_coll.s[i])
                    {
                        break;
                    }
                }
                if (j == index)
                {
                    v_result.insert(ip_coll.s[i]);
                }
            }
            return v_result;
        }
    }
}
