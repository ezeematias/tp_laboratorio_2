using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class Components
    {
        static int mother;
        static int core;
        static int readCard;
        static int moduleAccess;
        static int display;
        static int fingerPrint;
        static int faceCamera;

        static Components()
        {
            mother = 10;
            core = 10;
            readCard = 10;
            moduleAccess = 10;
            display = 10;
            fingerPrint = 10;
            faceCamera = 10;
        }

        public static int Mother
        {
            get
            {
                return mother;
            }
            set
            {
                if (mother > 0)
                    mother = value;
            }
        }
        public static int Core
        {
            get
            {
                return core;
            }
            set
            {
                if (core > 0)
                    core = value;
            }
        }
        public static int ReadCard
        {
            get
            {
                return readCard;
            }
            set
            {
                if (readCard > 0)
                    readCard = value;
            }
        }
        public static int ModuleAccess
        {
            get
            {
                return moduleAccess;
            }
            set
            {
                if (moduleAccess > 0)
                    moduleAccess = value;
            }
        }
        public static int Display
        {
            get
            {
                return display;
            }
            set
            {
                if (display > 0)
                    display = value;
            }
        }
        public static int FingerPrint
        {
            get
            {
                return fingerPrint;
            }
            set
            {
                if (fingerPrint > 0)
                    fingerPrint = value;
            }
        }
        public static int FaceCamera
        {
            get
            {
                return faceCamera;
            }
            set
            {
                if (faceCamera > 0)
                    faceCamera = value;
            }
        }

    }
}
