using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class CameraManager<T>
    {
        private List<T> cameraInfos = new List<T>();

        public void AddCameraInfo(T info)
        {
            cameraInfos.Add(info);
        }

        public void RemoveCameraInfo(T info)
        {
            cameraInfos.Remove(info);
        }


        public void CameraCount(int count)
        {
            Console.WriteLine(count);
        }

    }
}
