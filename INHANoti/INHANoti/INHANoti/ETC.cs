using System.Collections.Generic;
using Xamarin.Forms;

namespace INHANoti
{
    public static class ETC
    {
        internal static List<Major> majors;
        public static WebView mainNotiWebView;
        public static bool nowMainShell = true;

        internal static void InitMajorURLs()
        {
            string[] major =
            {
                "프런티어 학부 - 일반",
                "프런티어 학부 - 수업",
                "공과대학",
                "기계공학과",
                "산업경영공학과",
                "고분자공학과",
                "환경공학과",
                "건축학 / 건축공학",
                "전기공학과",
                "정보통신공학과",
                "항공우주공학과",
                "화학공학과",
                "신소재공학과",
                "공간정보공학과",
                "에너지자원공학과",
                "전자공학과",
                "조선해양공학과",
                "생명공학과",
                "사회인프라공학과",
                "컴퓨터공학과",
                "자연과학대학",
                "수학과",
                "화학과",
                "식품영양학과",
                "통계학과",
                "생명과학과",
                "물리학과",
                "해양과학과",
                "경영대학",
                "경영학과",
                "국제통상학과",
                "글로벌금융학과",
                "아태물류학부",
                "사범대학",
                "국어교육과",
                "교육학과",
                "영어교육과",
                "체육교육과",
                "사회교육과",
                "수학교육과",
                "사회과학대학",
                "행정학과",
                "경제학과",
                "사회복지학과",
                "정치외교학과",
                "소비자학과",
                "언론정보학과",
                "아동심리학과",
                "문과대학",
                "한국어문학과",
                "중국학과",
                "프랑스언어문화학과",
                "사학과",
                "일본언어문화학과",
                "문화콘텐츠문화경영학과",
                "철학과",
                "영어영문학과",
                "의예과",
                "간호학과",
                "미래융합대학",
                "메카트로닉공학과",
                "금융세무재테크학과",
                "소프트웨어융합공학과",
                "산업경영학과",
                "예술체육학부",
                "조형예술학과",
                "연극영화학과",
                "디자인융합학과",
                "의류디자인학과",
                "스포츠학과",
                "국제학부"
            };

            string[] urls =
            {
                "https://generaledu.inha.ac.kr/board_notice/list.aspx",
                "https://generaledu.inha.ac.kr/board_notice_class/list.aspx",
                "https://engcollege.inha.ac.kr/engcollege/640/subview.do",
                "https://mech.inha.ac.kr/board_notice/list.aspx",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=1089&siteId=ie",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=5111&siteId=inhapoly",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=1229&siteId=iuee",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=6357&siteId=arch",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=1009&siteId=electrical",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=6712&siteId=ice",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=7043&siteId=aerospace",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=5950&siteId=chemeng",
                "http://inhasmse.cafe24.com/bbs/board.php?bo_table=notice",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=1517&siteId=geoinfo",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=4991&siteId=eneres",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=1125&siteId=einha",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=1477&siteId=naoe",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=2185&siteId=bio",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=5842&siteId=civil",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=6594&siteId=cse",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=867&siteId=nscollege",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=2362&siteId=math",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=2964&siteId=chemistry",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=5374&siteId=foodnutri",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=2410&siteId=statistics",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=658&siteId=biology",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=3555&siteId=physics",
                "http://www.wdn.co.kr/html/info02.php",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=4479&siteId=biz",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=7105&siteId=bisin",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=673&siteId=star",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=3463&siteId=gfiba",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=4167&siteId=logistics",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=907&siteId=edcollege",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=6105&siteId=koreanedu",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=6271&siteId=education",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=6167&siteId=dele",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=2924&siteId=physicaledu",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=3697&siteId=social",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=6136&siteId=mathed",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=2246&siteId=sscollege",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=3338&siteId=publicad",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=275&siteId=tecon",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=2081&siteId=welfare",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=3304&siteId=political",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=5177&siteId=consumer",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=5449&siteId=comm",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=6958&siteId=child",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=940&siteId=hacollege",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=1043&siteId=korean",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=2476&siteId=china",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=3129&siteId=france",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=5314&siteId=history",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=7858&siteId=japan",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=4951&siteId=culturecm",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=5070&siteId=philosophy",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=4658&siteId=english",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=5682&siteId=medicine",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=3845&siteId=nursing",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=765&siteId=cfc",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=765&siteId=cfc",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=765&siteId=cfc",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=765&siteId=cfc",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=765&siteId=cfc",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=7797&siteId=artsports",
                "http://finearts.inha.ac.kr/",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=5905&siteId=theatrefilm",
                "http://www.inhadesign.com/44277516484932454637",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=5239&siteId=fashion",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=3517&siteId=sport",
                "https://dept.inha.ac.kr/user/indexSub.do?codyMenuSeq=2507&siteId=international"
            };

            majors = new List<Major>(20);

            for (int i = 0; i < major.Length; ++i)
            {
                majors.Add(new Major()
                {
                    Name = major[i],
                    URL = urls[i]
                });
            }

            majors.TrimExcess();
        }
    }
}