using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
	public class UserValidationManager : IUserValidationService
	{
		public bool IsRealPerson(User user)
		{
			if ((user.UserFirstName=="Olcay") && (user.UserLastName=="Güneş") && (user.UserTcNo=="1234567890") && (user.UserBirthYear==1992))
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
