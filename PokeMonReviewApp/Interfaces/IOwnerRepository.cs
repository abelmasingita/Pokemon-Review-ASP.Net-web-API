﻿using PokeMonReviewApp.Models;

namespace PokeMonReviewApp.Interfaces
{
    public interface IOwnerRepository
    {

        ICollection<Owner> GetOwners();
        Owner GetOwner(int id);

        ICollection<Owner> GetOwnerofAPokemon(int pokeId);
        ICollection<Pokemon> GetPokemonByOwner(int ownerId);
        bool OwnerExists(int id);
    }
}
