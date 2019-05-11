using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Monster : BaseNotificationClass
    {
        private int _hitPoints;

        public int HitPoints
        {
            get { return _hitPoints; }
            private set
            {
                _hitPoints = value;
                OnPropertyChanged(nameof(HitPoints));
            }
        }
        public string Name { get; set; }
        public string ImageName { get; set; }
        public int MaximumHitPoints { get; private set; }

        public int RewardExperiencePoints { get; private set; }
        public int RewardGold { get; private set; }

        public ObservableCollection<ItemQuantity> Inventory { get; set; }

        public Monster(string name, string imageName, int maximumHitPoints, int hitPoints, int rewardExperiencePoints, int rewardGold)
        {
            Name = name;
            // 把当前项目文件夹搞到然后再把图片的绝对路径名称搞过来，方便加载图片
            string path = Environment.CurrentDirectory;
            int indexNum = path.IndexOf(@"WPFUI\bin", 0, path.Length);
            string folderPath = path.Remove(indexNum);
            ImageName = string.Format(@"{0}Engine\Images\Monsters\{1}", folderPath, imageName);
            //

        

            //ImageName = string.Format(@"E:\C#Project\SOSCSRPG\Engine\Images\Monsters\{0}", imageName);// 不知道为什么不加载图片，所以就直接用路径来索引资源
            MaximumHitPoints = maximumHitPoints;
            HitPoints = hitPoints;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;

            Inventory = new ObservableCollection<ItemQuantity>();
        }



    }
}
