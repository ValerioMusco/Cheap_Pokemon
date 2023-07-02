using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Exceptions {
    public class AttackNotFoundException : Exception {

        public AttackNotFoundException( string message ) : base( message ) { }
    }
}
