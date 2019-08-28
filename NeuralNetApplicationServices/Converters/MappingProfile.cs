﻿using AutoMapper;
using NeuralNetApi.Requests;
using NeuralNetDomainService.DomainObjects;
using NeuralNetInfrastructure.Entities;
using System.Linq;

namespace NeuralNetApplicationServices.Converters
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<NeuralWeb, NeuralWebDomain>()
                .ForMember(dest => dest.Neurons, opt => opt.MapFrom(c => c.Neurons.ToDictionary(p => p.Id)))
                .ForMember(dest => dest.Synapses, opt => opt.MapFrom(c => c.Synapses.ToDictionary(p => p.Id)))
                .ReverseMap();

            CreateMap<Neuron, NeuronDomain>()
                .ForMember(dest => dest.IdNeuron, opt => opt.MapFrom(c => c.Id))
                .ReverseMap();

            CreateMap<Synapse, SynapseDomain>()
                .ForMember(dest => dest.IdSynapse, opt => opt.MapFrom(c => c.Id))
                .ForMember(dest => dest.IdInput, opt => opt.MapFrom(c => c.NeuronIdInput))
                .ForMember(dest => dest.IdOutput, opt => opt.MapFrom(c => c.NeuronIdOutput))
                .ReverseMap();

            CreateMap<NeuralWeb, NeuralWebCreatingRequest>().ReverseMap();

            CreateMap<Neuron, NeuronCreatingRequest>().ReverseMap();

            CreateMap<Synapse, SynapseCreatingRequest>().ReverseMap();
        }
    }
}
