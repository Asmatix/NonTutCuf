using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Features;
using Exiled.API.Enums;
using Exiled.CreditTags;
using PlayerRoles.Spectating;
using Exiled.Events.EventArgs.Player;
using Exiled.API.Features.Roles;
using PlayerRoles;
using MEC;
using TestPlugin;

namespace NonTutCuf
{
    public class NonTutCuf : Plugin<Config>
    {
        public override string Author => "davidclarkfri22";
        public override string Name => "NonTutCuf";
        public override string Prefix => "NTC";
        public override void OnEnabled()
        {
            Exiled.Events.Handlers.Player.Handcuffing += HandCuffs;
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.Handcuffing -= HandCuffs;
            base.OnDisabled();
        }
        private void HandCuffs(HandcuffingEventArgs ev)
        {
            if (Global.Player_Role.ContainsKey("035"))
            {
                if (Global.Player_Role["035"] != ev.Target)
                {
                    ev.IsAllowed = false;
                    Timing.CallDelayed(0.02f, () =>
                    {
                        ev.IsAllowed = true;
                    });

                    ev.Target.RemoveHandcuffs();
                    ev.Player.Handcuff();
                    ev.Player.DropItems();

                    Timing.CallDelayed(2f, () =>
                    {
                        ev.Player.RemoveHandcuffs();
                    });
                }
            }
            else
            {
                ev.IsAllowed = false;
                Timing.CallDelayed(0.02f, () =>
                {
                    ev.IsAllowed = true;
                });

                ev.Target.RemoveHandcuffs();
                ev.Player.Handcuff();
                ev.Player.DropItems();

                Timing.CallDelayed(2f, () =>
                {
                    ev.Player.RemoveHandcuffs();
                });
            }
            if (Global.Player_Role["343"] != ev.Target)
            {
                if (Global.Player_Role["343"] != ev.Target)
                {
                    ev.IsAllowed = false;
                    Timing.CallDelayed(0.02f, () =>
                    {
                        ev.IsAllowed = true;
                    });

                    ev.Target.RemoveHandcuffs();
                    ev.Player.Handcuff();
                    ev.Player.DropItems();

                    Timing.CallDelayed(2f, () =>
                    {
                        ev.Player.RemoveHandcuffs();
                    });
                }
            }
        }
    }
}
