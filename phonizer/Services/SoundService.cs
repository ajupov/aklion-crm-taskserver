using System.Media;
using System.Windows.Forms;

namespace Phonizer.Services
{
    public static class SoundService
    {
        private static SoundPlayer _soundPlayer = new SoundPlayer();
        public static void Play()
        {
            _soundPlayer.SoundLocation = Application.StartupPath + @"\phone.wav";
            _soundPlayer.Load();
            _soundPlayer.Play();
        }
    }
}