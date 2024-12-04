using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Inheritance
{
    internal class ActorManager
    {
        public List<Actor> actorList = new List<Actor>();

        private Actor boss;

        public ActorManager(Actor boss) 
        {
            this.boss = boss;;
        }

        public void AddName(string value)
        {
            this.boss.AddName(value);
        }


        public List<ExtraActor> GetExtraActor()
        {
            List<ExtraActor> actors = new List<ExtraActor>();

            foreach (var actor in actorList)
            {
                ExtraActor exActor = actor as ExtraActor;
                if(exActor != null)
                    actors.Add(exActor);
            }

            return actors;
        }
    }
}
