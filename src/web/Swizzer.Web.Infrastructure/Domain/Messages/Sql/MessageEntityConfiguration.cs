using Microsoft.EntityFrameworkCore;
using Swizzer.Web.Infrastructure.Domain.Messages.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Swizzer.Web.Infrastructure.Domain.Messages.Sql
{
    class MessageEntityConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Message> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Receiver)
                       .WithMany(x => x.ReceivedMessages)
                       .HasForeignKey(x => x.ReceiverId);

            builder.HasOne(x => x.Sender)
                       .WithMany(x => x.SentMessages)
                       .HasForeignKey(x => x.SenderId);

        }
    }
}
