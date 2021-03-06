﻿// Copyright (c) 2014 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under GPL v3. See LICENSE.md for details.
#if SILICONSTUDIO_PLATFORM_WINDOWS_DESKTOP

using SiliconStudio.Core;

namespace SiliconStudio.Paradox.Audio.Tests
{
    // Somehow it helps Resharper NUnit to run module initializer first (to determine unit test configuration).
    public class Module
    {
        [ModuleInitializer]
        internal static void Initialize()
        {
            if (!Platform.IsVirtualFileSystemInitialized)
                Platform.ApplicationDataSubDirectory = typeof(Module).Assembly.GetName().Name;
        }
    }
    // Somehow it helps Resharper NUnit to run module initializer first (to determine unit test configuration).
    [NUnit.Core.Extensibility.NUnitAddin]
    public class ModuleAddin : NUnit.Core.Extensibility.IAddin
    {
        public bool Install(NUnit.Core.Extensibility.IExtensionHost host)
        {
            return false;
        }
    }
}

#endif