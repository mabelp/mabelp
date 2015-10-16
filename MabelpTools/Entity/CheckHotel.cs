using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MabelpTools.Entity
{
    public class CheckHotel
    {
        /// <summary>
        /// 酒店ID
        /// </summary>
        public int HotelId { get; set; }
        /// <summary>
        /// 酒店Token
        /// </summary>
        public string HotelToken { get; set; }
        /// <summary>
        /// 酒店名称
        /// </summary>
        public string HotelName { get; set; }
        /// <summary>
        /// 房型ID
        /// </summary>
        public int RoomId { get; set; }
        /// <summary>
        /// 房型Token
        /// </summary>
        public string RoomToken { get; set; }
        /// <summary>
        /// 房型名称
        /// </summary>
        public string RoomName { get; set; }

        public string BedWidth { get; set; }
        /// <summary>
        /// 房型要求
        /// </summary>
        public List<RoomItemView> BedTypes { get; set; }
        /// <summary>
        /// 吸烟要求
        /// </summary>
        public List<RoomItemView> Smokes { get; set; }
    }

    public class RoomItemView
    {
        public int Type { get; set; }
        public string Token { get; set; }
        public string GroupTitle { get; set; }
        public string Remark { get; set; }
    }
}
