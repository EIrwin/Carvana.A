
FROM mono

MAINTAINER Eric Irwin <eric.irwin@carvana.com>

# Copy source files
RUN mkdir '/home/a'
ADD / /home/a

RUN nuget restore /home/Carvana.A/Carvana.A.sln &&  xbuild /home/Carvana.A/Carvana.A.sln

EXPOSE 12345

ENTRYPOINT ["mono", "/home/Carvana.A/Carvana.A.Gateway/bin/Debug/Carvana.A.Gateway.exe"]