from django.shortcuts import render
from django.http import HttpResponse

def index(request):
    return HttpResponse("<em>My Second App</em>")
def help(request):
    return HttpResponse("Help Page")
def my_page_view(request):
    return render(request, 'my_page.html')
# Create your views here.
