using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidParentheses {
    class Solution {
        List<char> parChecker = new List<char>();
        public bool IsValid(string s) {

            for (int b = 0; b < s.Length; b++) {
                parChecker.Add(s[b]);
                CheckForPair();
            }

            if (parChecker.Count == 0) {
                return true;
            } else {
                return false;
            }
        }

        private void CheckForPair() {
            int first;
            for (int i = 0; i < parChecker.Count; i++) {
                if (i == '{') {
                    first = i;
                    for (int j = i; j < parChecker.Count; j++) {
                        if (j == '}') {
                            parChecker.Remove(parChecker[first]);
                            parChecker.Remove(parChecker[j]);
                        }
                    }
                }

                for (int i = 0; i < parChecker.Count; i++) {
                    if (i == '[') {
                        first = i;
                        for (int j = i; j < parChecker.Count; j++) {
                            if (j == ']') {
                                parChecker.Remove(parChecker[first]);
                                parChecker.Remove(parChecker[j]);
                            }
                        }
                    }
                }

                for (int i = 0; i < parChecker.Count; i++) {
                    if (i == '(') {
                        first = i;
                        for (int j = i; j < parChecker.Count; j++) {
                            if (j == ')') {
                                parChecker.Remove(parChecker[first]);
                                parChecker.Remove(parChecker[j]);
                            }
                        }
                    }
                }

            }
        }
    }
}
