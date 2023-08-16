using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Utilites;
using Hospital.ViewModels;

namespace Hospital.Services
{
    public interface IRoomService
    {
        PagedResult<RoomViewModel> GetAll(int pageNumber, int pageSize);
        RoomViewModel GetRoomById(int RoomId);
        void UpdateRoom(RoomViewModel roomInfo);
        void InsertRoom(RoomViewModel roomInfo);
        void DeleteRoom(int id);

    }
}
