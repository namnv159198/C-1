using System;
using System.Collections.Generic;

namespace T1809E_CSharp
{
    
        public delegate void ChangeValue(String s);

        public class PhoneBook : Phone
        {
            public List<PhoneNumber> PhoneList = new List<PhoneNumber>();

            public event ChangeValue PhoneChange;


            public override bool insertPhone(string name, string phone)
            {
                foreach (PhoneNumber p in PhoneList)
                {

                    if (PhoneList == null)
                    {
                        PhoneList = new List<PhoneNumber>();
                    }

                    if (p.Name.Equals(name))
                    {

                        if (!p.Phone.Equals(phone))
                        {
                            p.Phone += " : " + phone;
                            if (PhoneChange != null)
                            {
                                PhoneChange(s: " The phone is being changed !");
                            }

                            return true;
                        }

                        return false;
                    }
                }

                PhoneList.Add(new PhoneNumber(name, phone));
                return true;
            }

            public static void notify(string s)
            {
                Console.WriteLine(s);
            }


            public override bool removePhone(string name)
            {

                foreach (PhoneNumber p in PhoneList)
                {
                    if (p.Name.Equals(name))

                    {
                        PhoneList.Remove(p);
                        return true;
                    }

                }

                return false;
            }


            public override bool updatePhone(string name, string newphone)
            {
                foreach (PhoneNumber p in PhoneList)
                {
                    if (p.Name.Equals(name))
                    {
                        p.Phone = newphone;
                        if (PhoneChange == null)
                        {
                            PhoneChange += notify;
                        }

                        PhoneChange(s: "The Phonenumber of " + name + " is being changed");
                        return true;
                    }
                }

                return false;
            }


            public override PhoneNumber searchPhone(string name)
            {
                foreach (PhoneNumber p in PhoneList)
                {
                    if (p.Name.Equals(name))
                    {
                        return p;
                    }
                }

                return null;
            }

            public override void viewPhone()
            {
                
                foreach (PhoneNumber p in PhoneList)
                {

                    Console.WriteLine("Name : " + p.Name + " - Phone : " + p.Phone);
                }


            }
        }
    }
