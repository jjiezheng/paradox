﻿// Copyright (c) 2014 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under GPL v3. See LICENSE.md for details.
using SiliconStudio.Assets;
using SiliconStudio.Core;

namespace SiliconStudio.Paradox.Assets.Audio
{
    [DataContract]
    public abstract class SoundAsset : AssetImport
    {
        /// <summary>
        /// The default file extension used by the <see cref="SoundMusicAsset"/>.
        /// </summary>
        public const string FileExtension = ".pdxsnd";
    }
}