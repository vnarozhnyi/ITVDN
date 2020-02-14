using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proffesional7
{
    enum AccessLevelControl
    {
        FullControl, MediumControl, LowControl
    }

    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    sealed class AccessLevelAttribute : Attribute
    {
        readonly AccessLevelControl accessLevel;

        public AccessLevelAttribute(AccessLevelControl accessLevel)
        {
            this.accessLevel = accessLevel;
        }

        public AccessLevelControl AccessLevel
        {
            get { return accessLevel; }
        }
    }

    class Employee
    {

    }

    [AccessLevel(AccessLevelControl.LowControl)]
    class Manager : Employee
    {

    }

    [AccessLevel(AccessLevelControl.MediumControl)]
    class Programmer : Employee
    {

    }

    [AccessLevel(AccessLevelControl.FullControl)]
    class Director : Employee
    {

    }
}
