﻿namespace NeuralNetApi
{
    public class NeuronCreatingRequest
    {
        /// <summary>
        /// Тип нейрона: входной, скрытый, выходной, NeuronTypeConst
        /// </summary>
        public byte NeuronType { get; private set; }

        public int NeuralNetId { get; set; }
    }
}