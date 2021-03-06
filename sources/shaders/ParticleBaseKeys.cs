// Copyright (c) 2014 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under GPL v3. See LICENSE.md for details.
using SiliconStudio.Paradox.Graphics;

namespace SiliconStudio.Paradox.Effects.Modules
{
    /// <summary>
    /// Keys used for the particle system.
    /// </summary>
    public static partial class ParticleBaseKeys
    {
        static ParticleBaseKeys()
        {
            ParticleGlobalBufferRO = ParticleGlobalBuffer;
            ParticleSortBufferRO = ParticleSortBuffer;
        }
    }
}