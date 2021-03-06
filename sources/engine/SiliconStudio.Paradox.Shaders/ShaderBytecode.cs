// Copyright (c) 2014 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under GPL v3. See LICENSE.md for details.
using System.Text;
using SiliconStudio.Core;
using SiliconStudio.Core.Serialization;
using SiliconStudio.Core.Storage;

namespace SiliconStudio.Paradox.Shaders
{
    /// <summary>
    /// The bytecode of an effect.
    /// </summary>
    [DataContract]
    public partial class ShaderBytecode
    {
        /// <summary>
        /// The stage of this Bytecode.
        /// </summary>
        public ShaderStage Stage;

        /// <summary>
        /// Hash of the Data.
        /// </summary>
        public ObjectId Id { get; set; }

        /// <summary>
        /// Gets the shader data that should be used to create the <see cref="Shader"/>.
        /// </summary>
        /// <value>
        /// The shader data.
        /// </value>
        public byte[] Data { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShaderBytecode"/> class.
        /// </summary>
        public ShaderBytecode()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShaderBytecode"/> class.
        /// </summary>
        /// <param name="data">The data.</param>
        public ShaderBytecode(ObjectId id, byte[] data)
        {
            Id = id;
            Data = data;
        }

        /// <summary>
        /// Performs an implicit conversion from <see cref="ShaderBytecode"/> to <see cref="System.Byte[][]"/>.
        /// </summary>
        /// <param name="shaderBytecode">The shader bytecode.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator byte[](ShaderBytecode shaderBytecode)
        {
            return shaderBytecode.Data;
        }

        /// <summary>
        /// Gets the data as a string.
        /// </summary>
        /// <returns>System.String.</returns>
        public string GetDataAsString()
        {
            return Encoding.UTF8.GetString(Data, 0, Data.Length);
        }
    }
}