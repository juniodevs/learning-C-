using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProposto221.Entities
{
    class Studant
    {
        public int StudantId { get; set; }

        public Studant(int studantId)
        {
            StudantId = studantId;
        }

        public override int GetHashCode()
        {
            return StudantId.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Studant))
            return false;
            Studant other = obj as Studant;
            return StudantId.Equals(other.StudantId);
        }
    }
}
