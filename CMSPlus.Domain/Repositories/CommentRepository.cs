using CMSPlus.Domain.Entities;
using CMSPlus.Domain.Interfaces;
using CMSPlus.Domain.Persistance;
using Microsoft.EntityFrameworkCore;

namespace CMSPlus.Domain.Repositories;

public class CommentRepository:Repository<CommentEntity>,ICommentRepository
{
    public CommentRepository(ApplicationDbContext context) : base(context)
    {
    }
    
    public async Task<List<CommentEntity>> GetCommentsByTopicSystemName(int topicId)
    {
        var comments = await _dbSet.Where(c => c.TopicId == topicId)
            .ToListAsync();
        return comments;
    }
}