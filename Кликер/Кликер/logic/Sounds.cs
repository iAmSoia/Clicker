using System;
using System.IO;
using System.Media;
using System.Reflection;

namespace Кликер
{
    public static class Sounds
    {
        private static readonly SoundPlayer mainButton = new SoundPlayer("E:\\учёба\\3 семестр\\ООП\\Кликер\\Clicker\\Кликер\\Кликер\\zz\\zvuk-nopki-v-kompyuternoy-igre1.wav");
        private static readonly SoundPlayer aсhievements4Sounds = new SoundPlayer("E:\\учёба\\3 семестр\\ООП\\Кликер\\Clicker\\Кликер\\Кликер\\zz\\рёв.wav");
        private static readonly SoundPlayer aсhievements3Sounds = new SoundPlayer("E:\\учёба\\3 семестр\\ООП\\Кликер\\Clicker\\Кликер\\Кликер\\zz\\Звук-Где-собака-бегает-по-таявшему-снегу.wav");
        private static readonly SoundPlayer click = new SoundPlayer("E:\\учёба\\3 семестр\\ООП\\Кликер\\Clicker\\Кликер\\Кликер\\zz\\клик.wav");
        private static readonly SoundPlayer aсhievements2Sounds = new SoundPlayer("E:\\учёба\\3 семестр\\ООП\\Кликер\\Clicker\\Кликер\\Кликер\\zz\\Bumblebee.wav");
        private static readonly SoundPlayer aсhievements1Sounds = new SoundPlayer("E:\\учёба\\3 семестр\\ООП\\Кликер\\Clicker\\Кликер\\Кликер\\zz\\Звук-с-появлением-святого-духа-или-священника.wav");

        public static void MainButtonSounds()
        {
            PlayButtonSounds(mainButton);
        }
        public static void Aсhievements4Sounds()
        {
            PlayButtonSounds(aсhievements4Sounds);
        }
        public static void Aсhievements3Sounds()
        {
            PlayButtonSounds(aсhievements3Sounds);
        }
        public static void Aсhievements2Sounds()
        {
            PlayButtonSounds(aсhievements2Sounds);
        }
        public static void Aсhievements1Sounds()
        {
            PlayButtonSounds(aсhievements1Sounds);
        }
        public static void AllSounds()
        {
            PlayButtonSounds(click);
        }
        private static void PlayButtonSounds(SoundPlayer soundPlayer)
        {
            try
            {
                soundPlayer.Play();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка воспроизведения звука: {ex.Message}");
            }
        }
    }
}
