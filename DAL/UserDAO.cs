using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class UserDAO: PostContext
    {
        public UserDTO GetUserWithUsernameAndPassword(UserDTO model)
        {
            UserDTO dto = new UserDTO();
            T_User user = db.T_User.FirstOrDefault(x => x.Username == model.Username && x.Password == model.Password);
            if(user != null && user.Id != 0) 
                dto.Id = user.Id;
                dto.Username = user.Username;
                dto.Name = user.NameSurname;
                dto.Imagepath = user.ImagePath;
                dto.IsAdmin = user.isAdmin;
            return dto;
        }
    }
}
