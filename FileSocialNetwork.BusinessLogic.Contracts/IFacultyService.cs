﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileSocialNetwork.Shared.Entities;

namespace FileSocialNetwork.BusinessLogic.Contracts
{
	public interface IFacultyService
	{
		IEnumerable<Faculty> GetFaculties();
		Faculty Create(string title);
	}
}
