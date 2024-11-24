using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CMSPlus.Domain.Entities;

public class CommentEntity:BaseEntity
{
    [MaxLength(48)]
    public string FullName { get; set; } = null!;
    [MaxLength(255)]
    public string Comment { get; set; } = null!;
    public int TopicId { get; set; }

    public TopicEntity Topic { get; set; } 
}