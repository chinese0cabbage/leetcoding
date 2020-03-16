using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCoding
{
    class PlayMahjong
    {
        private Man Dad;
        private Man Mom;
        private Man ZhangKe;
        private Man ZhangJun;
        public PlayMahjong()
        {
            this.Dad = new Man("dad", 1);
            this.Mom = new Man("mom", 2);
            this.ZhangKe = new Man("zhangke", 3);
            this.ZhangJun = new Man("zhangjun", 4);
        }
        public void Play()
        {
            Console.WriteLine("请输入获胜玩家Id,1:dad,2:mom,3:zhangke,4:zhangjun");
            int winId = Convert.ToInt32(int.Parse(Console.ReadLine()));
            Console.WriteLine("请输入获胜玩家倍数");
            int times = Convert.ToInt32(int.Parse(Console.ReadLine()));
            Console.WriteLine("请输入失败玩家Id,1:dad,2:mom,3:zhangke,4:zhangjun,0代表自摸，不可输入获胜玩家Id");
            int loseId = Convert.ToInt32(int.Parse(Console.ReadLine()));
            if (winId == loseId)
            {
                Console.WriteLine("输赢玩家ID相同，请重新输入");
                Play();
                return;
            }
            Man winner = SearchManById(winId);
            if (loseId == 0)
            {
                winner.WinAll(times);
                for (int i = 1; i < 5; i++)
                {
                    if (i != winId)
                    {
                        Man loser = SearchManById(i);
                        loser.Lose(times);
                    }
                }
            }
            else
            {
                Man loser = SearchManById(loseId);
                winner.WinOne(times);
                loser.Lose(times);
            }
        }
        public void Settlement()
        {
            Console.WriteLine("所有人的初始金额均为10元");
            Dad.Settlement();
            Mom.Settlement();
            ZhangKe.Settlement();
            ZhangJun.Settlement();
        }
        private Man SearchManById(int id)
        {
            if (this.Dad.Id == id)
                return this.Dad;
            else if (this.Mom.Id == id)
                return this.Mom;
            else if (this.ZhangKe.Id == id)
                return this.ZhangKe;
            else
                return this.ZhangJun;
        }
    }

    class Man
    {
        public string Name;
        public int Id;
        private double Money;
        public Man(string name,int id)
        {
            this.Name = name;
            this.Id = id;
            this.Money = 10;
        }
        public void WinAll(int times)
        {
            this.Money += 0.5 * 3 * times;
        }
        public void WinOne(int times)
        {
            this.Money += 0.5 * times;
        }
        public void Lose(int times)
        {
            this.Money -= 0.5 * times;
        }
        public void Settlement()
        {
            double leftMoney = 10 - this.Money;
            if (leftMoney >= 0)
            {
                Console.WriteLine("玩家{0}赢了{1}元", this.Name, this.Money);
            }
            else
            {
                Console.WriteLine("玩家{0}输了{1}元", this.Name, this.Money);
            }
        }
    }
}
