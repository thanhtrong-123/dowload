# Generated by Django 4.2.5 on 2023-10-10 13:13

import datetime
from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('weblog', '0004_comment'),
    ]

    operations = [
        migrations.AddField(
            model_name='post',
            name='draft',
            field=models.BooleanField(default=False),
        ),
        migrations.AddField(
            model_name='post',
            name='publish',
            field=models.DateField(default=datetime.datetime(2023, 10, 10, 13, 13, 2, 185223, tzinfo=datetime.timezone.utc)),
            preserve_default=False,
        ),
    ]
