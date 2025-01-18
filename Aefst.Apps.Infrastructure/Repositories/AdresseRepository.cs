using Aefst.Apps.Core.Interfaces;
using Aefst.Apps.Core.Models;
using Aefst.Apps.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Aefst.Apps.Infrastructure.Repositories
{
    public class AdresseRepository : IAdresseRepository
    {
        private readonly AefstAppsDbContext _context;

        public AdresseRepository(AefstAppsDbContext context)
        {
            _context = context;
        }

        public async Task<Adresse> Create(Adresse adresse)
        {
            try
            {
                if (adresse == null)
                {
                    throw new ArgumentNullException(nameof(adresse), "Adresse cannot be null");
                }

                _context.Adresses.Add(adresse);
                await _context.SaveChangesAsync();
                return adresse;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while creating the address.", ex);
            }
        }

        public async Task Delete(Guid id)
        {
            try
            {
                var adresse = await _context.Adresses.FindAsync(id);
                if (adresse == null)
                {
                    throw new KeyNotFoundException("Address not found");
                }

                _context.Adresses.Remove(adresse);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while deleting the address with ID {id}.", ex);
            }
        }

        public async Task<List<Adresse>> GetAll()
        {
            try
            {
                return await _context.Adresses.AsNoTracking().ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving all addresses.", ex);
            }
        }

        public async Task<Adresse> GetById(Guid id)
        {
            try
            {
                var adresse = await _context.Adresses.AsNoTracking().FirstOrDefaultAsync(a => a.Id == id);
                if (adresse == null)
                {
                    throw new KeyNotFoundException($"Address with ID {id} not found.");
                }

                return adresse;
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while retrieving the address with ID {id}.", ex);
            }
        }

        public async Task<Adresse> GetByName(string name)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(name))
                {
                    throw new ArgumentException("Name cannot be null or empty.", nameof(name));
                }

                var adresse = await _context.Adresses.AsNoTracking().FirstOrDefaultAsync(a => a.Arrondissement.Equals(name, StringComparison.OrdinalIgnoreCase));
                if (adresse == null)
                {
                    throw new KeyNotFoundException($"Address with name '{name}' not found.");
                }

                return adresse;
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while retrieving the address with name '{name}'.", ex);
            }
        }

        public async Task<Adresse> Update(Adresse adresse)
        {
            try
            {
                if (adresse == null)
                {
                    throw new ArgumentNullException(nameof(adresse), "Adresse cannot be null");
                }

                var existingAdresse = await _context.Adresses.FindAsync(adresse.Id);
                if (existingAdresse == null)
                {
                    throw new KeyNotFoundException($"Address with ID {adresse.Id} not found.");
                }

                _context.Entry(existingAdresse).CurrentValues.SetValues(adresse);
                await _context.SaveChangesAsync();
                return adresse;
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while updating the address with ID {adresse.Id}.", ex);
            }
        }
    }
}
