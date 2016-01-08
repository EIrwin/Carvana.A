
FROM mono

MAINTAINER Eric Irwin <eric.irwin@carvana.com>

# Copy source files
RUN mkdir '/home/a'
ADD / /home/a

RUN nuget restore /home/a/Carvana.A.sln &&  xbuild /home/a/Carvana.A.sln

EXPOSE 12345

ENTRYPOINT ["mono", "/home/a/Carvana.A.Gateway/bin/Debug/Carvana.A.Gateway.exe"]