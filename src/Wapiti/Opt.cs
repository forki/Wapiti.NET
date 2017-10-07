﻿using System.Runtime.InteropServices;

namespace Wapiti
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct Opt
    {
        [MarshalAs(UnmanagedType.I4)]
        public int Mode;
        public string Input;
        public string Output;
        [MarshalAs(UnmanagedType.U1)]
        public bool MaxEnt;

        // Options for training
        public string Type;
        public string Algo;
        public string Pattern;
        public string Model;
        public string Devel;
        public string RState;
        public string SState;
        [MarshalAs(UnmanagedType.U1)]
        public bool Compact;
        [MarshalAs(UnmanagedType.U1)]
        public bool Sparse;
        [MarshalAs(UnmanagedType.U4)]
        public uint NThread;
        [MarshalAs(UnmanagedType.U4)]
        public uint JobSize;
        [MarshalAs(UnmanagedType.U4)]
        public uint MaxIter;
        public double Rho1;
        public double Rho2;

        // Window size criterion
        [MarshalAs(UnmanagedType.U4)]
        public uint ObjWin;
        [MarshalAs(UnmanagedType.U4)]
        public uint StopWin;
        public double StopEps;

        // Options specific to L-BFGS
        [MarshalAs(UnmanagedType.U1)]
        public bool Clip;
        [MarshalAs(UnmanagedType.U4)]
        public uint HistSz;
        [MarshalAs(UnmanagedType.U4)]
        public uint MaxLs;

        // Options specific to SGD-L1
        public double Eta0;
        public double Alpha;

        // Options specific to BCD
        public double Kappa;

        // Options specific to RPROP
        public double StpMin;
        public double StpMax;
        public double StpInc;
        public double StpDec;
        [MarshalAs(UnmanagedType.U1)]
        public bool CutOff;

        // Options for labelling
        [MarshalAs(UnmanagedType.U1)]
        public bool Label;
        [MarshalAs(UnmanagedType.U1)]
        public bool Check;
        [MarshalAs(UnmanagedType.U1)]
        public bool OutSc;
        [MarshalAs(UnmanagedType.U1)]
        public bool LblPost;
        [MarshalAs(UnmanagedType.U4)]
        public uint NBest;
        [MarshalAs(UnmanagedType.U1)]
        public bool Force;

        // Options for model dump
        [MarshalAs(UnmanagedType.I4)]
        public int Prec;
        [MarshalAs(UnmanagedType.U1)]
        public bool All;
    }
}