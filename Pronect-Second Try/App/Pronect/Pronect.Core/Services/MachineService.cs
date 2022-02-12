using System;
using System.Collections.Generic;
using System.Text;

namespace Pronect.Services
{
    public interface IMachineService
    {
        void Connect();

        void Authorize(string password);
    }
}
