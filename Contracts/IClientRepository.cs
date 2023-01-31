﻿using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IClientRepository
    {
        IEnumerable<Client> GetAllClients(bool trackChanges);
        Client GetCLientByName (string name,bool trackChanges);
    }
}
