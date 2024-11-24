using AutoMapper;
using CMSPlus.Domain.Entities;
using CMSPlus.Domain.Models.CommentModels;
using CMSPlus.Services.Interfaces;
using CMSPlus.Domain.Models.TopicModels;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;

namespace CMSPlus.Presentation.Controllers;

public class CommentController : Controller
{
    private readonly ICommentService _commentService;
    private readonly IMapper _mapper;

    public CommentController(ICommentService commentService, IMapper mapper)
    {
        _commentService = commentService;
        _mapper = mapper;
    }
    
    // [HttpPost]
    // public async Task<IActionResult> Edit(TopicEditModel updatedEntity)
    // {
    //     var validationResult = await _editModelValidator.ValidateAsync(updatedEntity);
    //     if (!validationResult.IsValid)
    //     {
    //         validationResult.AddToModelState(this.ModelState);
    //         return View(updatedEntity);
    //     }
    //
    //     var topicEntity = await _topicService.GetById(updatedEntity.Id);
    //     topicEntity = _mapper.Map(updatedEntity, topicEntity);
    //     await _topicService.Update(topicEntity);
    //     return RedirectToAction("Index");
    // }
    
    // [HttpPost]
    // [ActionName("Delete")]
    // public async Task<IActionResult> DeleteById(int id)
    // {
    //     await _topicService.Delete(id);
    //     return RedirectToAction("Index");
    // }
    
    [HttpPost]
    public async Task<IActionResult> Create(TopicDetailsModel topic)
    {
        var commentEntity = _mapper.Map<CommentCreateModel, CommentEntity>(topic.CreateComment);
        await _commentService.Create(commentEntity);
        return RedirectToAction("Details", "Topic", new { systemName = topic.SystemName });
    }
}