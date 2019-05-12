using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Monster : LivingEntity
    {

        #region Properities

        public string ImageName { get; set; }
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }
        public int RewardExperiencePoints { get; private set; }

        #endregion
        public Monster(string name, string imageName, int maximumHitPoints, int currentHitPoints, int minimumDamage, int maximumDamage, int rewardExperiencePoints, int gold) : base(name, maximumDamage, currentHitPoints, gold)
        {
            #region  把当前项目文件夹搞到然后再把图片的绝对路径名称搞过来，方便加载图片
            string path = Environment.CurrentDirectory;
            int indexNum = path.IndexOf(@"WPFUI\bin", 0, path.Length);
            string folderPath = path.Remove(indexNum);
            #endregion
            ImageName = string.Format(@"{0}Engine\Images\Monsters\{1}", folderPath, imageName);
            MinimumDamage = minimumDamage;
            MaximumDamage = maximumDamage;
            RewardExperiencePoints = rewardExperiencePoints;
        }



    }
}
