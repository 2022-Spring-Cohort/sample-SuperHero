using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroes
{
    class SuperHero
    {
        private bool Flying;
        private string RealName;
        private string Weakness;
        private bool Costume;
        private string Backstory;
        private bool TragicBackstory;
        private string GenderIdentity;

        public SuperHero()
        {
            this.Flying = false;
            this.RealName = "";
            this.Weakness = "";
            this.Costume = false;
            this.Backstory = "";
            this.TragicBackstory = false;
            this.GenderIdentity = "";
        }

        public SuperHero(bool flying, string realname, string weakness, bool costume, string backstory, bool tragic, string gender)
        {
            this.Flying = flying;
            this.RealName = realname;
            this.Weakness = weakness;
            this.Costume = costume;
            this.Backstory = backstory;
            this.TragicBackstory = tragic;
            this.GenderIdentity = gender;
        }

        public void SetFlying(bool flying)
        {
            this.Flying = flying;
        }

        public void SetRealName(string name)
        {
            this.RealName = name;
            
        }

        public void SetWeakness(string weakness)
        {
            this.Weakness = weakness;
        }

        public void SetCostume(bool costume)
        {
            this.Costume = costume;
        }

        public void SetBackstory(string backstory, bool tragic)
        {
            this.Backstory = backstory;
            this.TragicBackstory = tragic;
        }

        public void SetGenderIdentity(string genderidentity)
        {
            this.GenderIdentity = genderidentity;
        }

        public bool GetFlying()
        {
            return this.Flying;
        }

        public string GetRealName()
        {
            return this.RealName;
        }

        public string GetWeakness()
        {
            return this.Weakness;
        }

        public bool GetCostume()
        {
            return this.Costume;
        }

        public string GetBackstory()
        {
            return this.Backstory;
        }

        public bool GetTragicBackstory()
        {
            return this.TragicBackstory;
        }

        public string GetGenderIdentity()
        {
            return this.GenderIdentity;
        }

        public override string ToString()
        {
            return "Real Name: " + this.RealName + "\nWeaknesses: " + this.Weakness + "\n";
        }

    }
}
