# AppTwo/templatetags/custom_tags.py
from django import template

register = template.Library()

@register.simple_tag
def static_image(image_path, alt_text="", **kwargs):
    return f'<img src="{{% static "{image_path}" %}}" alt="{alt_text}" {% for key, value in kwargs.items %} {key}="{value}" {% endfor %}>'
