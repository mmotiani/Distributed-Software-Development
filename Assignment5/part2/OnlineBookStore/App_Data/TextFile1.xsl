<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/">
    <html>
      <body>
        <b>
          <center style="font-size:15pt; font-family:times new roman;" >List of Books available</center>
        </b>
        <table border="1" align="center">
          <tr bgcolor="pink" style="font-size:15pt; font-family:times new roman;">
            <td  align="center">
              Book Name
            </td>
            <td align="center">
              Price
            </td>
            <td  align="center">
              Quantity
            </td>
          </tr>


          <xsl:for-each select="listofbooks/book">
            <xsl:sort select="name"/>
            <tr style="font-size:12pt; font-family:times new roman">

              <td>
                <xsl:value-of select="name"/>
              </td>
              <td>
                <xsl:value-of select="value"/>
              </td>
              <td>
                <xsl:value-of select="quantity"/>
              </td>


            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>