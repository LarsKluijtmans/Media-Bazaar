﻿using ClassLibraryProject.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryProject.ManagmentClasses.IAllManager
{
    public interface IPreferredShiftAllManager
    {
        PreferredShift GetPreferredShift(string day, string shift);
    }
}