/*
    Copyright(c) 2015 Neodymium

    Permission is hereby granted, free of charge, to any person obtaining a copy
    of this software and associated documentation files (the "Software"), to deal
    in the Software without restriction, including without limitation the rights
    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
    copies of the Software, and to permit persons to whom the Software is
    furnished to do so, subject to the following conditions:

    The above copyright notice and this permission notice shall be included in
    all copies or substantial portions of the Software.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
    THE SOFTWARE.
*/

using RageLib.Resources.Common;
using System.Collections.Generic;

namespace RageLib.Resources.GTA5.PC.Particles
{
    public class Unknown_P_032 : ResourceSystemBlock
    {
        public override long Length
        {
            get { return 88; }
        }

        // structure data
        public uint Unknown_0h;
        public uint Unknown_4h;
        public uint Unknown_8h;
        public uint Unknown_Ch;
        public uint Unknown_10h;
        public uint Unknown_14h;
        public uint Unknown_18h;
        public uint Unknown_1Ch;
        public uint Unknown_20h;
        public uint Unknown_24h;
        public uint Unknown_28h;
        public uint Unknown_2Ch;
        public uint Unknown_30h;
        public uint Unknown_34h;
        public uint Unknown_38h;
        public uint Unknown_3Ch;
        public ulong p12;
        public ushort c12a;
        public ushort c12b;
        public uint Unknown_4Ch;
        public uint Unknown_50h;
        public uint Unknown_54h;

        // reference data
        public ResourceSimpleArray<uint_r> p12data;

        /// <summary>
        /// Reads the data-block from a stream.
        /// </summary>
        public override void Read(ResourceDataReader reader, params object[] parameters)
        {
            // read structure data
            this.Unknown_0h = reader.ReadUInt32();
            this.Unknown_4h = reader.ReadUInt32();
            this.Unknown_8h = reader.ReadUInt32();
            this.Unknown_Ch = reader.ReadUInt32();
            this.Unknown_10h = reader.ReadUInt32();
            this.Unknown_14h = reader.ReadUInt32();
            this.Unknown_18h = reader.ReadUInt32();
            this.Unknown_1Ch = reader.ReadUInt32();
            this.Unknown_20h = reader.ReadUInt32();
            this.Unknown_24h = reader.ReadUInt32();
            this.Unknown_28h = reader.ReadUInt32();
            this.Unknown_2Ch = reader.ReadUInt32();
            this.Unknown_30h = reader.ReadUInt32();
            this.Unknown_34h = reader.ReadUInt32();
            this.Unknown_38h = reader.ReadUInt32();
            this.Unknown_3Ch = reader.ReadUInt32();
            this.p12 = reader.ReadUInt64();
            this.c12a = reader.ReadUInt16();
            this.c12b = reader.ReadUInt16();
            this.Unknown_4Ch = reader.ReadUInt32();
            this.Unknown_50h = reader.ReadUInt32();
            this.Unknown_54h = reader.ReadUInt32();

            // read reference data
            this.p12data = reader.ReadBlockAt<ResourceSimpleArray<uint_r>>(
                this.p12, // offset
                this.c12a
            );
        }

        /// <summary>
        /// Writes the data-block to a stream.
        /// </summary>
        public override void Write(ResourceDataWriter writer, params object[] parameters)
        {
            // update structure data
            this.p12 = (ulong)(this.p12data != null ? this.p12data.Position : 0);
            //this.c12a = (ushort)(this.p12data != null ? this.p12data.Count : 0);

            // write structure data
            writer.Write(this.Unknown_0h);
            writer.Write(this.Unknown_4h);
            writer.Write(this.Unknown_8h);
            writer.Write(this.Unknown_Ch);
            writer.Write(this.Unknown_10h);
            writer.Write(this.Unknown_14h);
            writer.Write(this.Unknown_18h);
            writer.Write(this.Unknown_1Ch);
            writer.Write(this.Unknown_20h);
            writer.Write(this.Unknown_24h);
            writer.Write(this.Unknown_28h);
            writer.Write(this.Unknown_2Ch);
            writer.Write(this.Unknown_30h);
            writer.Write(this.Unknown_34h);
            writer.Write(this.Unknown_38h);
            writer.Write(this.Unknown_3Ch);
            writer.Write(this.p12);
            writer.Write(this.c12a);
            writer.Write(this.c12b);
            writer.Write(this.Unknown_4Ch);
            writer.Write(this.Unknown_50h);
            writer.Write(this.Unknown_54h);
        }

        /// <summary>
        /// Returns a list of data blocks which are referenced by this block.
        /// </summary>
        public override IResourceBlock[] GetReferences()
        {
            var list = new List<IResourceBlock>();
            if (p12data != null) list.Add(p12data);
            return list.ToArray();
        }

    }
}