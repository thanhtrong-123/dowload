from django.shortcuts import render
from django.views.generic import ListView, DetailView, CreateView, UpdateView, DeleteView
from .models import Post,Comment
from .form import PostFrom, CommentFrom
from django.urls import reverse_lazy
def home(request):
    return render(request, 'home.html')

class HomeView(ListView):
    model = Post
    template_name = 'home.html'
    ordering = ['-id']

class DraftView(ListView):
    model = Post
    template_name = 'draft.html'
    ordering = ['-id']
class CreatePostView(CreateView):
    model = Post
    form_class = PostFrom
    template_name = 'create_post.html'
    success_url = reverse_lazy('draft')
class ArticleDetailView(DetailView):
    model = Post
    template_name = 'article_detail.html'
class AddCommentView(CreateView):
    model = Comment
    template_name = 'add_comment.html'
    form_class = CommentFrom
    success_url = reverse_lazy('HomeView')
    def form_valid(self, form):
        form.instance.post_id = self.kwargs['pk']
        return super().form_valid(form)
    

class EditPostView(UpdateView):
    model = Post
    template_name = 'edit_post.html'
    fields = ['title', 'body','draft','publish']

class DeletePostView(DeleteView):
    model = Post
    template_name = 'delete_post.html'
    success_url = reverse_lazy('HomeView')

