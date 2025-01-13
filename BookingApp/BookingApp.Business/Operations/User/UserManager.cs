using BookingApp.Business.DataProtection;
using BookingApp.Business.Operations.User.Dtos;
using BookingApp.Business.Types;
using BookingApp.Data.Entities;
using BookingApp.Data.Enums;
using BookingApp.Data.Repositories;
using BookingApp.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.Business.Operations.User
{
    public class UserManager : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<UserEntity> _userRepository;
        private readonly IDataProtection _protector;

        public UserManager(IUnitOfWork unitOfWork, IRepository<UserEntity> userRepository, IDataProtection protector)
        {

            _unitOfWork = unitOfWork;

            _userRepository = userRepository;

            _protector = protector;

        }

        public async Task<ServiceMessage> AddUser(AddUserDto user)
        {
            var HasMail = _userRepository.GetAll(x => x.Email.ToLower() == user.Email.ToLower());

            if (HasMail.Any())
            {
                return new ServiceMessage
                {
                    IsSucceed = false,
                    Message = "email adresi zaten var"
                };

            }

            var userEntity = new UserEntity()
            {
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Password = _protector.Protect(user.Password),
                BirthDate = user.BirthDate,
                UserType = UserType.Customer

            };
            _userRepository.Add(userEntity);

            try
            {
                await _unitOfWork.SaveChangesAsync();

            }
            catch (Exception)
            {

                throw new Exception("kullanıcı kaydı sırasında bir hata oluştu");
            }

            return new ServiceMessage
            {
                IsSucceed = true,


            };

        }

        public ServiceMessage<UserInfoDto> LoginUser(LoginUserDto user)
        {
            var userentity = _userRepository.Get(x => x.Email.ToLower() == user.Email.ToLower());

            if (userentity == null)
            {
                return new ServiceMessage<UserInfoDto>
                {
                    IsSucceed = false,
                    Message = "ad veya şifre hatalı"

                };
            }

            var unprotectedPassword = _protector.UnProtect(userentity.Password);

            if (unprotectedPassword == user.Password)
            {
                return new ServiceMessage<UserInfoDto>


                {
                    IsSucceed = true,
                    Data = new UserInfoDto

                    {
                        Email = userentity.Email,
                        FirstName = userentity.FirstName,
                        LastName = userentity.LastName,
                        UserType = userentity.UserType,

                    }


                };
            
            
            }

            else
            {
                return new ServiceMessage<UserInfoDto>
                {

                    IsSucceed = false,
                    Message = "ad vya şifre hatalı"
                };

            }
        }
    }
}