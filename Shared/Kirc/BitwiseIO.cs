﻿using System;
using System.IO;

namespace NoxShared
{
	public class BitReader
	{
		/// <summary>
		/// Bit buffer - 8 bits
		/// </summary>
		byte bitBuf;
		/// <summary>
		/// Position in the bit buffer - starts from 8
		/// </summary>
		int bitPos = 0;

		/// <summary>
		/// Input byte buffer
		/// </summary>
		byte[] buffer;
		/// <summary>
		/// Position in the byte buffer
		/// </summary>
		int bufPos = 0;

		public int BufferPos
		{
			get
			{
				return bufPos;
			}
		}

		public BitReader(byte[] buffer)
		{
			this.buffer = buffer;
		}

		public int ReadBit()
		{
			// Peek another 8 bits if bitbuffer is empty
			if (bitPos <= 0)
			{
				bitBuf = buffer[bufPos];
				bufPos++;
				bitPos = 8;
			}

			int result = (bitBuf & 0x80) >> 7;
			bitBuf <<= 1;
			bitPos--;
			return result;
		}

		public int Read(int bitCount)
		{
			int result = 0;
			// Lil optimization: if bitbuffer has enough bits do shift directly
			if (bitPos >= bitCount)
			{
				result = bitBuf >> (8 - bitCount);
				bitBuf <<= bitCount;
				bitPos -= bitCount;
				return result;
			}

			for (int i = 0; i < bitCount; i++)
				result = (result << 1) | ReadBit();

			return result;
		}
	}

	public class BitWriter
	{
		/// <summary>
		/// Bit buffer - 8 bits
		/// </summary>
		byte bitBuf;

		/// <summary>
		/// Position in the bit buffer - starts from 8
		/// </summary>
		int bitPos;

		/// <summary>
		/// Output stream that may be converted to byte array
		/// </summary>
		MemoryStream output;

		public BitWriter(int segmentSize)
		{
			// To my extensive benchmarking, in C#, the MemoryStream is much faster than low-level byte array magic. 
			// Believe me or not. Maybe it has a bigger buffer -- I don't know.
			output = new MemoryStream(segmentSize);
			bitPos = 0;
			bitBuf = 0;
		}

		public void Write(int val, int len)
		{
			if (!output.CanWrite) return;

			// Notice that bits are written in reverse order
			while (len > 0)
			{
				if (bitPos >= 8)
				{
					output.WriteByte(bitBuf);
					bitBuf = 0;
					bitPos = 0;
				}
				len--;
				bitBuf <<= 1;
				bitBuf |= (byte)((val & (1 << len)) >> len);
				bitPos++;
			}
		}

		public byte[] Close()
		{
			// Append remaining bits (bitPos may be 8)
			if (bitPos > 0) output.WriteByte((byte)(bitBuf << 8 - bitPos));
			// Close stream
			output.Close();
			// Return byte array
			return output.ToArray();
		}
	}
}
