﻿using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public class ActorsService : IActorService
    {
        private readonly AppDbContext _context;
        public ActorsService(AppDbContext cotext)
        {
            _context = cotext;
        }

        public async Task AddAsync(Actor actor)
        {
            await _context.Actors.AddAsync(actor);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var results = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);
            _context.Actors.Remove(results);
            await _context.SaveChangesAsync();
        }
        public async Task<IEnumerable<Actor>> GetAll()
        {
            var results = await _context.Actors.ToListAsync();
            return results;
        }

        public async Task<IEnumerable<Actor>> GetAllAsync()
        {
            var result = await _context.Actors.ToListAsync();
            return result;
        }

        public async Task<Actor> GetByIdAsync(int id)
        {
            var results = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);
            return results;
        }

        public async Task<Actor> UpdateAsync(int id, Actor newActor)
        {
            _context.Update(newActor);
            await _context.SaveChangesAsync();
            return newActor;
        }
    }
}
