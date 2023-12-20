using System;
using System.Media;

namespace Кликер
{
    interface ISounds
    {
        void AllSounds();
        void MainButtonSounds();
        void Aсhievements4Sounds();
        void Aсhievements3Sounds();
        void Aсhievements2Sounds();
        void Aсhievements1Sounds();
    }

    public class Sounds : ISounds
    {
        private readonly SoundPlayer mainButton = new SoundPlayer("E:\\учёба\\3 семестр\\ООП\\Кликер\\Clicker\\Кликер\\Кликер\\zz\\zvuk-nopki-v-kompyuternoy-igre1.wav");
        private readonly SoundPlayer aсhievements4Sounds = new SoundPlayer("E:\\учёба\\3 семестр\\ООП\\Кликер\\Clicker\\Кликер\\Кликер\\zz\\рёв.wav");
        private readonly SoundPlayer aсhievements3Sounds = new SoundPlayer("E:\\учёба\\3 семестр\\ООП\\Кликер\\Clicker\\Кликер\\Кликер\\zz\\Звук-Где-собака-бегает-по-таявшему-снегу.wav");
        private readonly SoundPlayer click = new SoundPlayer("E:\\учёба\\3 семестр\\ООП\\Кликер\\Clicker\\Кликер\\Кликер\\zz\\клик.wav");
        private readonly SoundPlayer aсhievements2Sounds = new SoundPlayer("E:\\учёба\\3 семестр\\ООП\\Кликер\\Clicker\\Кликер\\Кликер\\zz\\Bumblebee.wav");
        private readonly SoundPlayer aсhievements1Sounds = new SoundPlayer("E:\\учёба\\3 семестр\\ООП\\Кликер\\Clicker\\Кликер\\Кликер\\zz\\Звук-с-появлением-святого-духа-или-священника.wav");

        public void MainButtonSounds()
        {
            PlayButtonSounds(mainButton);
        }
        public void Aсhievements4Sounds()
        {
            PlayButtonSounds(aсhievements4Sounds);
        }
        public void Aсhievements3Sounds()
        {
            PlayButtonSounds(aсhievements3Sounds);
        }
        public void Aсhievements2Sounds()
        {
            PlayButtonSounds(aсhievements2Sounds);
        }
        public void Aсhievements1Sounds()
        {
            PlayButtonSounds(aсhievements1Sounds);
        }
        public void AllSounds()
        {
            PlayButtonSounds(click);
        }
        private void PlayButtonSounds(SoundPlayer soundPlayer)
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
