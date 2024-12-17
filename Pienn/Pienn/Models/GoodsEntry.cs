using System;
using System.Collections.Generic;
using System.Text;

namespace Pienn.Models
{
    public class GoodsEntry
    {
        public int Id { get; set; }
        public string Title { get; set; }  //名稱
        public string Source { get; set; } //圖片
        public int Price { get; set; } //價格
        public int Num { get; set; }  //數量
        public string Remark { get; set; }  //備註
    }
}
