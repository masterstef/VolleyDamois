using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using VolleyDamois.Models;

namespace VolleyDamois.Validation
{
    public class TeamAttribute : ValidationAttribute
    {
        [Team(ErrorMessage = "Il faut au moins une fille dans l'équipe")]
        public override bool IsValid(object value)
        {
            //TODO
            Team vm = (Team)value;
            return HasAtLeastOneWomenInTeam(vm) && CaptainHasTelNumAndEmail(vm) && GoodNumberOFPlayerInTeam(vm);
         
        }

        private bool GoodNumberOFPlayerInTeam(Team vm)
        {
            if (vm.Category.Category.Equals(Category.Nationale))
            {
                return vm.Players.Count >= 3 && vm.Players.Count <= 4;
            }
            else
            {
                return vm.Players.Count >= 4 && vm.Players.Count <= 6;
            }
        }

        private bool CaptainHasTelNumAndEmail(Team vm)
        {
            return vm.Players[0].Email != null && vm.Players[0].TelNumber != null;
        }

        private bool HasAtLeastOneWomenInTeam(Team vm)
        {
            foreach (Player p in vm.Players)
            {
                if (p.Sex.Sexe == Sexe.femme) {
                    return true;
                }
            }

            return false;
        }
    }
}
