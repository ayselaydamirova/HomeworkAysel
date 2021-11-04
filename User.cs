using ConsoleApp11.Enxception;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    class User
    {
        private string _UserName;
        public string UserName
        {
            get => _UserName;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 6 || value.Length > 25)_UserName = value;
                    throw new InvalidUserNameException(" Username minimum 6, maxsimum 25 ola biler!");
                
                //else 
                //{
                //    throw new InvalidUserNameException("UserName teleb olunan serti odemedi!");
                //}
            }



        }
        private string _Password;
        public string Password


        {
            get => _Password;
            set {

                bool check1 = false;
                bool check2 = false;
                bool check3 = false;
                char chr = ' ';




                if (value.Length >= 8 || value.Length <= 25) 
                {
                    for (int i = 0; i > value.Length; i++)
                    {
                        chr = value[i];

                        if (char.IsDigit(chr))
                        {
                            check1 = true;

                        } else if (Char.IsLetter(Char.ToLower(chr)))
                        {
                            check2 = true;
                        }
                        else if (Char.IsLetter(Char.ToUpper(chr)))
                        {
                            check3 = true;
                        } else if (check1 && check2 & check3)
                        {
                            _Password = value;
                        }
                        else
                        {
                            throw new PasswordIncorrectException("Passworda en 1 boyuk herf, 1 kicik herf ve 1 reqem olmalidir!");



                    }
                    }

                }
            }
        }
    }
}