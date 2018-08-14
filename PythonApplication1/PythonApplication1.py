from fake_useragent import UserAgent

ua = UserAgent()

f = open("foo.txt", "w")

for i in range(0, 500):
  f.write('            \"\\"{}\\"\",\n'.format(ua.random))
