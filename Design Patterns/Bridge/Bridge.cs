using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Remote
    {
        public Device MyDevice { get; set; }

        public Remote(Device d)
        {
            MyDevice = d;
        }

        public void IncreaseVolume()
        {
            MyDevice.ChangeVolumeBy(1);
        }

        public void DecreaseVolume()
        {
            MyDevice.ChangeVolumeBy(-1);
        }
    }

    public interface Device
    {
        void ChangeVolumeBy(int volume);
    }

    public class TV : Device
    {
        public int Volume { get; set; }

        public TV(int volume)
        {
            Volume = volume;
        }

        public void ChangeVolumeBy(int volume)
        {
            Volume += volume;
        }
    }

    public class Radio : Device
    {
        public int Volume { get; set; }

        public Radio(int volume)
        {
            Volume = volume;
        }

        public void ChangeVolumeBy(int volume)
        {
            Volume += volume;
        }
    }
}
