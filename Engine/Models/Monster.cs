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

        #region Properities
        private int _hitPoints;

        public string Name { get; set; }
        public string ImageName { get; set; }
        public int MaximumHitPoints { get; private set; }
        public int HitPoints
        {
            get { return _hitPoints; }
            set
            {
                _hitPoints = value;
                OnPropertyChanged(nameof(HitPoints));
            }
        }
        public int MinimumDamage { get; set; }
        public int MaxmumDamage { get; set; }

        public int RewardExperiencePoints { get; private set; }
        public int RewardGold { get; private set; }

        public ObservableCollection<ItemQuantity> Inventory { get; set; }
        #endregion
        public Monster(string name, string imageName, int maximumHitPoints, int hitPoints,int minimumDamage, int maxmumDamage, int rewardExperiencePoints, int rewardGold)
        {
            #region  把当前项目文件夹搞到然后再把图片的绝对路径名称搞过来，方便加载图片
            string path = Environment.CurrentDirectory;
            int indexNum = path.IndexOf(@"WPFUI\bin", 0, path.Length);
            string folderPath = path.Remove(indexNum);
            #endregion
            Name = name;
            ImageName = string.Format(@"{0}Engine\Images\Monsters\{1}", folderPath, imageName);
            MaximumHitPoints = maximumHitPoints;
            HitPoints = hitPoints;
            MinimumDamage = minimumDamage;
            MaxmumDamage = maxmumDamage;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;

            Inventory = new ObservableCollection<ItemQuantity>();
        }



    }
}
