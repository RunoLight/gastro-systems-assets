using System;

namespace BinaryCalc
{
    public class Calculus
    {
        public struct Term
        {
            public string binary; //2
            public string octal; //8
            public int denary; //10
            public string hexadecimal; //16

            public Term(string binary_, string octal_, int denary_, string hexademical_)
            {
                binary = binary_;
                octal = octal_;
                denary = denary_;
                hexadecimal = hexademical_;
            }

            public void RefreshBy(int key) //2 - binary, 8 - octal, 10 - denary, 16 - hexademical
            {
                switch (key)
                {
                    case 2:
                        denary = Convert.ToInt32(binary, 2);
                        break;

                    case 8:
                        denary = Convert.ToInt32(octal, 8);
                        break;

                    case 10:
                        break;

                    case 16:
                        denary = Convert.ToInt32(hexadecimal, 16);
                        break;
                }

                binary = Convert.ToString(denary, 2);
                octal = Convert.ToString(denary, 8);
                hexadecimal = Convert.ToString(denary, 16);
            }

            #region operators
            static public Term operator +(Term var1, Term var2)
            {
                Term var3 = new Term
                {
                    denary = var1.denary + var2.denary
                };
                var3.RefreshBy(10);
                return var3;
            }

            static public Term operator -(Term var1, Term var2)
            {
                Term var3 = new Term
                {
                    denary = var1.denary - var2.denary
                };
                var3.RefreshBy(10);
                return var3;
            }

            static public Term operator *(Term var1, Term var2)
            {
                Term var3 = new Term
                {
                    denary = var1.denary * var2.denary
                };
                var3.RefreshBy(10);
                return var3;
            }

            static public Term operator /(Term var1, Term var2)
            {
                Term var3 = new Term
                {
                    denary = var1.denary / var2.denary
                };
                var3.RefreshBy(10);
                return var3;
            }

            static public Term operator |(Term var1, Term var2)
            {
                Term var3 = new Term
                {
                    denary = var1.denary | var2.denary
                };
                var3.RefreshBy(10);
                return var3;
            }

            static public Term operator ^(Term var1, Term var2)
            {
                Term var3 = new Term
                {
                    denary = var1.denary ^ var2.denary
                };
                var3.RefreshBy(10);
                return var3;
            }

            static public Term operator ~(Term var1)
            {
                Term var2 = new Term
                {
                    denary = ~var1.denary
                };
                var2.RefreshBy(10);
                return var2;
            }

            static public Term operator >>(Term var1, int var2)
            {
                Term var3 = new Term
                {
                    denary = var1.denary >> var2
                };
                var3.RefreshBy(10);
                return var3;
            }

            static public Term operator <<(Term var1, int var2)
            {
                Term var3 = new Term
                {
                    denary = var1.denary << var2
                };
                var3.RefreshBy(10);
                return var3;
            }
            #endregion operators
        }
    }
}