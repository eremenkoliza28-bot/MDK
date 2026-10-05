using ClassroomBooking.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomBooking.Services
{
    internal class RoomService
    {
        private readonly List<Room> rooms = new List<Room>
        {
            new Room { Id = 1, Number = "301", ComputerCount = 15, IsAvailable = true,  MaxGroupSize = 20 },
            new Room { Id = 2, Number = "302", ComputerCount = 20, IsAvailable = true,  MaxGroupSize = 25 },
            new Room { Id = 3, Number = "305", ComputerCount = 12, IsAvailable = false, MaxGroupSize = 15 }
        };

        public List<Room> GetRooms()
        {
            return rooms;
        }
    }
}
