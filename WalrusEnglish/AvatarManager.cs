using System;
using System.Drawing;
using WalrusEnglishGui.Properties;

namespace WalrusEnglishGui
{
    static class AvatarManager
    {
        private const int AvatarCount = 10;
        private const string AvatarNameBase = "avatar";

        public static Image GetAvatarByNumber(int avatarNumber, bool flip = false)
        {
            var avatar = (Image) Resources.ResourceManager.GetObject(string.Format("{0}{1}", AvatarNameBase, avatarNumber.ToString("D2"))) ??
                Resources.avatar01;
            
            if (flip)
                avatar.RotateFlip(RotateFlipType.RotateNoneFlipX);
            
            return avatar;
        }

        public static Image GetNextAvatar(ref int avatarNumber, bool flip = false)
        {
            if (avatarNumber == AvatarCount)
                avatarNumber = 1;
            else
                avatarNumber++;

            return GetAvatarByNumber(avatarNumber, flip);
        }
    }
}
